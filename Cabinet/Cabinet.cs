using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Cabinet
{
    public class Cabinet
    {
        private User user;
        public Boolean EtatConnexion = false;
        public DataTable dtutilisateurs;
        public User CurrentUser;
        public Antecedent CurrentAntecedent;
        public Patient CurrentPatient;
        public ListeAttente CurrentListeAttente;
        public DataTable dtville;
        public DataTable dtPatients;
        public DataTable dtAntecedent;
        public DataTable dtMedicament;
        public DataTable dtListeAttente;
        public DataTable dtMedicamentPrescri;
        public MedicamentPrescri CurrentMedicamentPriscri;
        public DataTable dtConsultation;
        public Consultation CurrentConsultation;
        public EvolutionST CurrentEvolution;

        public DataTable dtExamenBiologique;
        public DataTable dtExamenDemmande;
        public DataTable dtHistoriqueMedicament;
        public DataTable dtHistoriqueExamen;
        public DataTable dtHistoriqueMaladies;
        public DataTable dtExamenRadiologique;
        public DataTable dtExamenRadioDemmandee;
        public DataTable dtHisoriqueExamenRadio;
        public DataTable dtExamensEndoscopiques;
        public DataTable dtExamenEndoscopiqueDemmande;
        public DataTable dtHitoriqueExamenEndoscopique;
        public DataTable dtExamenAnatomo;
        public DataTable dtExamenAnatomoDemmande;
        public DataTable dtHistoriqueExamenAnatomo;
        public DataTable dtEvolution;



    public User User
    {
  get { return user; }
  set { user = value; }
    }
    public Cabinet(User u)
    {

    this.User = u;
    }
    //constructeur de la class cabinet  qui attend u user 


       
    public void AuthentifierMoi()
    {
        User temp = this.User;
        if (IsExist())
        {
            this.User = getuser();

            this.User.Login = temp.Login;
            this.User.Password = temp.Password;
            this.User.Cabinet = temp.Cabinet;
            this.User.Type = temp.Type;
            this.User.Cn = temp.Cn;
            User.AfficherInterface();

            EtatConnexion = true;
        }
    
    }

    public  Boolean IsExist()
    {

        Boolean rep = false;
        string pass;

        try
        {
            SqlDataReader dr;
            SqlCommand cmd1 = new SqlCommand("select login from utilisateurs where login='"+user.Login+"'",user.Cn);
            user.Cn.Open();
            dr = cmd1.ExecuteReader();
            if (dr.HasRows)
            {
                if (user.Cn.State==ConnectionState.Open)
                {
                    user.Cn.Close();
                }
                SqlCommand cmd = new SqlCommand("select password from utilisateurs where login='" + this.User.Login + "' ", User.Cn);
                User.Cn.Open();
                pass = cmd.ExecuteScalar().ToString();
                User.Cn.Close();
                if (User.Password.Equals(pass))
                {
                    rep = true;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("le mot de passe est incorrect !");

                }    
            }
            else
            {
                MessageBox.Show("Login incorrect !");
            }
            
        }
        catch (Exception  )
        {
           

           System.Windows.Forms.MessageBox.Show("Connexion au serveur introuvable ! Veuillez verifier les parametres réseau , ou Contacter Mr Raki Mohammed");
            

        }
  
        return rep;
    }

    public   string getType()
    { 
        string tp=null;

        SqlCommand cmd = new SqlCommand("select type from utilisateurs where login='"+this.User.Login+"'",User.Cn);
        User.Cn.Open();
        tp = cmd.ExecuteScalar().ToString();
        User.Cn.Close();

        return tp;
    }

    public User getuser()
    {
        User u = null;
        string type;
        type = getType();
        switch (type)
        {
            case "admin":u=new Admin();
                
                break;

            case "secretaire": u = new Secretaire();
                break;

            case "medcin": u = new Medcin();
                break;
        }

        return u;
    
    }


    public DataTable getdt(string cmdtxt)
    {
       

       SqlDataAdapter da = new SqlDataAdapter("" + cmdtxt + "", this.user.Cn);
        DataTable dt = new DataTable();
        da.Fill(dt);
        
       return dt;
    }


    public void AjouterUtilisateur(User u)
    {


        try
        {
            SqlCommand cmd = new SqlCommand("insert into utilisateurs values ('" + u.Login + "','" + u.Password + "','" + u.Type + "')", User.Cn);
            User.Cn.Open();
            cmd.ExecuteNonQuery();
            User.Cn.Close();
            System.Windows.Forms.MessageBox.Show("utilisateur a été ajouté avec succes !");
        }
        catch (Exception )
        {

           System.Windows.Forms.MessageBox.Show("cet utilisateur existe deja !");
           User.Cn.Close();
        }
        
    }

    public void ChargerDtUtilisateurs()
    {

        this.dtutilisateurs = new DataTable();

        dtutilisateurs = this.getdt("select * from utilisateurs");
    
    
    }


    public void ViderTxtBox(Form f)
    {

        foreach (Control c in f.Controls)
        {

            
                    if (c is TextBox)
                    {
                        c.Text = "";
                    }
             
        }
    
    }


    public void SupprimerUtilisateur()
    {

        SqlCommand cmd = new SqlCommand("delete utilisateurs where login='"+user.Cabinet.CurrentUser.Login+"'",user.Cn);
        user.Cn.Open();
        cmd.ExecuteNonQuery();
        user.Cn.Close();
        MessageBox.Show("Utilisateur supprimé avec succes !");
    
    
    }

    public void modifierUtilisateur(User u)
    {

        SqlCommand cmd = new SqlCommand("update utilisateurs set login='"+u.Login+"', password='"+u.Password+"' , type ='"+u.Type+"' where login='"+User.Cabinet.CurrentUser.Login+"'",User.Cn);
        User.Cn.Open();
        cmd.ExecuteNonQuery();
        User.Cn.Close();
        MessageBox.Show("L'utilisateur a été modifié avec succes");
    
    
    }

    public void chargerLesVille()
    {

        this.dtville = getdt("select * from ville");
    
    }

    public void chargedtPatients()
    {

        this.dtPatients = getdt("select * from patient");
    
    
    }
    public void AjouterPatient(Patient p)
    {


        string oldpoids = p.Poids.ToString();
        string newpoids = oldpoids.Replace(",", ".");//ici on a essai de trompu le serveur pour accepter la vergule
  
         SqlCommand cmd = new SqlCommand("insert into patient values('" + p.Nom + "','" + p.Prenom + "','" + p.Cin + "','" + p.Sexe + "','" + p.Telephone + "','" + p.DateNaissance + "','" + p.Ville + "','" + newpoids + "','"+p.Mutualiste+"')", User.Cn);
         User.Cn.Open();
         cmd.ExecuteNonQuery();
         User.Cn.Close();
         MessageBox.Show("Le patient a été ajouté avec succes !");
    
    }

    public void SupprimerPatient()
    {

        SqlCommand cmd = new SqlCommand("delete patient where Id_Patient='"+User.Cabinet.CurrentPatient.IdPatient+"'",User.Cn);
        User.Cn.Open();
        cmd.ExecuteNonQuery();
        User.Cn.Close();
        MessageBox.Show("Le patient a été supprimé avec succes !");
    
    }
    public void modifierPatient(Patient p)
    {
        string oldpoids = p.Poids.ToString();
        string newpoids = oldpoids.Replace(",", ".");//ici on a essai de trompu le serveur pour accepter la vergule
        
            SqlCommand cmd = new SqlCommand("update patient set nom='" + p.Nom + "',prenom='" + p.Prenom + "',cin='" + p.Cin + "',sexe='" + p.Sexe + "',tel='" + p.Telephone + "',dateNaissance='" + p.DateNaissance + "',ville='" + p.Ville + "',poids='" + newpoids + "' ,mutualiste='"+p.Mutualiste+"' where Id_patient='" + CurrentPatient.IdPatient + "'", user.Cn);
            User.Cn.Open();
            cmd.ExecuteNonQuery();
            User.Cn.Close();
            MessageBox.Show("Le patient a été modifié avec succes !");
               
      
    
    }

    public void chercherPatientParNom(string nom)
    {
        User.Cabinet.dtPatients = getdt("select * from patient where nom like'%"+nom+"%'");
    
    }
    public void chercherPatientParCin(string cin)
    {
        User.Cabinet.dtPatients = getdt("select * from patient where cin like '%" + cin + "%'");

    }

    public void chercherParVille(string ville)
    {

        User.Cabinet.dtPatients = getdt("select * from patient where ville = '" + ville + "'");
    }

    public void chargerDtMedicament()
    {

        dtMedicament = getdt("select * from medicament order by nomcomercial ");
    
    }
    public void chargerDtAntecedent(Patient p)
    {

        dtAntecedent = getdt("select id_Antecedent ,antecedent_type , medicament_type from antecedents where id_patient='"+p.IdPatient+"'");
    
    }

    public void ajouterAntecedent(Antecedent ant)
    {
        SqlCommand cmd = new SqlCommand("insert into antecedents values ('"+user.Cabinet.CurrentPatient.IdPatient+"','"+ant.Anteceden+"','"+ant.Medicament+"')",user.Cn);
        if (user.Cn.State==System.Data.ConnectionState.Open)
        {
            user.Cn.Close();
        }
        user.Cn.Open();
        cmd.ExecuteNonQuery();
        user.Cn.Close();
        
        
    }
    public void supprimerAntecedent()
    {
        if (user.Cn.State==ConnectionState.Open)
        {
            user.Cn.Close();
        }
        if (!(user.Cabinet.CurrentAntecedent==null))
        {
            SqlCommand cmd = new SqlCommand("delete antecedents where id_antecedent='" + user.Cabinet.CurrentAntecedent.Id_antecedent + "'", user.Cn);
            user.Cn.Open();
            cmd.ExecuteNonQuery();
            user.Cn.Close();
            

        }
        else
        {
            MessageBox.Show("Vous devez selectionner un antecedent !");
        }
    
    }
    public void modifierAntecedent(Antecedent ant)
    {
        


        SqlCommand cmd = new SqlCommand(" update antecedents set antecedent_type ='"+ant.Anteceden+"' ,medicament_type='"+ant.Medicament+"' where id_Antecedent='"+user.Cabinet.CurrentAntecedent.Id_antecedent+"'",user.Cn);
        user.Cn.Open();
        cmd.ExecuteNonQuery();
        user.Cn.Close();
        MessageBox.Show("L 'antecedent a été modifié avec succes!");
    }

    public void ajouterMedicament(string nomcommercial)
    {
        if (user.Cn.State==ConnectionState.Open)
        {
            user.Cn.Close();
        }
        SqlCommand cmd1 = new SqlCommand("select * from medicament where nomComercial='" + nomcommercial + "'", user.Cn);
        SqlDataReader dr;
        user.Cn.Open();
        dr = cmd1.ExecuteReader();
        
        if (dr.HasRows)
        {
            MessageBox.Show("Ce medicament existe deja !");
            dr.Close();

        }
        else
        {
            if (user.Cn.State==ConnectionState.Open)
            {
                user.Cn.Close();
            }


            SqlCommand cmd = new SqlCommand("insert into medicament values ('" + nomcommercial + "')", user.Cn);
            user.Cn.Open();
            cmd.ExecuteNonQuery();
            user.Cn.Close();
            MessageBox.Show("Le medicament a été bien ajouté !");
        }

        user.Cn.Close();

    }

    public void supprimerMedicament(string nomCom)
    {
        SqlCommand cmd = new SqlCommand("delete medicament where nomComercial ='"+nomCom+"'",user.Cn);
        user.Cn.Open();
        cmd.ExecuteNonQuery();
        user.Cn.Close();
        MessageBox.Show("Le medicament a été supprimé avec succes !");
    
    }

    public void chercherMedicament(string nom)
    {
        dtMedicament = getdt("select * from medicament where nomComercial like '"+nom+"%'");
    }

    public void AjouterAlaListeDattente(ListeAttente ls)
    {
        SqlDataReader dr;
        SqlCommand cmd1 = new SqlCommand("select * from listeAttente where id_patient='"+ls.Id_patient+"'",user.Cn);
        user.Cn.Open();
        dr = cmd1.ExecuteReader();
        if (dr.HasRows)
        {
            MessageBox.Show("Ce patient est déja dans la liste d'attente");
            User.Cn.Close();
        }
        else
        {
            if (user.Cn.State==ConnectionState.Open)
            {
                user.Cn.Close();
            }
            SqlCommand cmd = new SqlCommand("insert into ListeAttente values ('" + ls.Id_patient + "','" + ls.Date.ToShortTimeString() + "','" + ls.MotifVisite + "','" + ls.Etat + "')", user.Cn);
            user.Cn.Open();
            cmd.ExecuteNonQuery();
            user.Cn.Close();
            MessageBox.Show("Le patient a été ajouté à la liste d'attente ");
        }


       
    
    }
    public void chargerListeAttente()
    {

        dtListeAttente = getdt("select patient.id_patient,patient.nom,patient.prenom,patient.cin,patient.sexe,patient.dateNaissance,patient.tel,patient.ville,ListeAttente.Motif_Visite,ListeAttente.HeureArrivee,ListeAttente.Etat from patient,ListeAttente where ListeAttente.id_patient=patient.Id_Patient and listeAttente.Etat='En attente' order by heurearrivee desc");
    }
    public void supprimerPatientDepuisListeAttente()
    {
        SqlCommand cmd = new SqlCommand("delete listeAttente where id_patient='"+user.Cabinet.CurrentListeAttente.Id_patient+"'",user.Cn);
        user.Cn.Open();
        cmd.ExecuteNonQuery();
        user.Cn.Close();
        MessageBox.Show("le patient a été retiré de la liste !");
    
    }

    public void supprimerAntecedentDuPatientSelectionne()
    {
        SqlCommand cmd = new SqlCommand("delete Antecedents where id_patient='" + user.Cabinet.CurrentPatient.IdPatient + "'", user.Cn);
        user.Cn.Open();
        cmd.ExecuteNonQuery();
        user.Cn.Close();
       
    }
    public void supprimerConsultationDuPatientSelectionne()
    {
        SqlCommand cmd = new SqlCommand("delete Consultation where id_patient='" + user.Cabinet.CurrentPatient.IdPatient + "'", user.Cn);
        user.Cn.Open();
        cmd.ExecuteNonQuery();
        user.Cn.Close();

    }
    public void supprimerPatientDepuisListeAttentePourLeSupprimerDefinitefement()
    {
        SqlCommand cmd = new SqlCommand("delete listeAttente where id_patient='" + user.Cabinet.CurrentPatient.IdPatient + "'", user.Cn);
        user.Cn.Open();
        cmd.ExecuteNonQuery();
        user.Cn.Close();
    }

    public Patient getPatientById(Int32 id)
    {
        Patient p;

        DataTable dt;
        dt = getdt("select * from patient where id_patient='"+id+"'");

        p = new Patient(Int32.Parse(dt.Rows[0][0].ToString()), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString(), dt.Rows[0][4].ToString(), dt.Rows[0][0].ToString(), DateTime.Parse(dt.Rows[0][6].ToString()), dt.Rows[0][7].ToString(), float.Parse(dt.Rows[0][8].ToString()));

        return p;
    }

    public void ajouterConsultation(Consultation consultation)
    {
        SqlCommand cmd = new SqlCommand("insert into consultation values ('"+consultation.IdPatient+"','"+consultation.DateConsultation+"','"+consultation.Maladie+"','"+consultation.Remarque+"')",user.Cn);
        User.Cn.Open();
        cmd.ExecuteNonQuery();
        user.Cn.Close();
        
    
    }

    public void SupprimerConsultation(Int32 idConsultation)
    {
        SqlCommand cmd1 = new SqlCommand("delete  MedicamentPrescri where id_consultation='" + idConsultation + "'", user.Cn);
        User.Cn.Open();
        cmd1.ExecuteNonQuery();
        user.Cn.Close();// pour medicamentPrescri

       // supp Analyse Demmande
        SqlCommand cmd2 = new SqlCommand("delete  AnalysesDemandees where id_consultation='" + idConsultation + "'", user.Cn);
        User.Cn.Open();
        cmd2.ExecuteNonQuery();
        user.Cn.Close();

        // supp Radio Demmande
        SqlCommand cmd3 = new SqlCommand("delete  RadioDemmande where id_consultation='" + idConsultation + "'", user.Cn);
        User.Cn.Open();
        cmd3.ExecuteNonQuery();
        user.Cn.Close();

        // supp Examen Endoscopique Demmande
        SqlCommand cmd4 = new SqlCommand("delete  ExamensEndoscopiquesDemmandees where id_consultation='" + idConsultation + "'", user.Cn);
        User.Cn.Open();
        cmd4.ExecuteNonQuery();
        user.Cn.Close();

        // supp Examen anatomo Demmande
        SqlCommand cmd5 = new SqlCommand("delete  ExamensAnatomoDemmandes where id_consultation='" + idConsultation + "'", user.Cn);
        User.Cn.Open();
        cmd5.ExecuteNonQuery();
        user.Cn.Close();

        SqlCommand cmd = new SqlCommand("delete  consultation where id_consultation='"+idConsultation+"'", user.Cn);
        User.Cn.Open();
        cmd.ExecuteNonQuery();
        user.Cn.Close();
    }
    public void updateConsultation(Int32 idConsultation,string maladie,string remarque)
    {
        SqlCommand cmd = new SqlCommand("update consultation set maladie='"+maladie+"' ,remarque='"+remarque+"' where id_consultation='"+idConsultation+"'", user.Cn);
        User.Cn.Open();
        cmd.ExecuteNonQuery();
        user.Cn.Close();
    }


    public void chargerDtMedicamentPrescri(Int32 idConsultation)
    {
        this.dtMedicamentPrescri = getdt("select MedicamentPrescri.id_dose, MedicamentPrescri.medicament,dose.dosage,dose.periode,MedicamentPrescri.DureTraitement from MedicamentPrescri,dose,Consultation where MedicamentPrescri.id_dose=dose.id_dose and Consultation.id_consultation=MedicamentPrescri.id_consultation and Consultation.id_consultation='" + idConsultation + "'");
    }

    public void retirerPatientduSalleAttente(Patient p)
    {
        SqlCommand cmd = new SqlCommand("delete listeAttente where id_Patient='"+p.IdPatient+"'", user.Cn);
        User.Cn.Open();
        cmd.ExecuteNonQuery();
        user.Cn.Close();
    
    }
    public void chargerTousLesconsultation()
    {
        dtConsultation = getdt("select  Consultation.id_consultation,  patient.nom,patient.prenom,patient.cin,Consultation.maladie,Consultation.remarque,Consultation.dateConsultation from patient,Consultation where patient.Id_Patient=Consultation.id_patient ");
    }

    public void chargerConsultationParDate(DateTime date)
    {
        dtConsultation = getdt("select  Consultation.id_consultation,  patient.nom,patient.prenom,patient.cin,Consultation.maladie,Consultation.remarque,Consultation.dateConsultation from patient,Consultation where patient.Id_Patient=Consultation.id_patient and consultation.DateConsultation='"+date+"'");
    }

    public void chargerConsultationParID(Int32 ID)
    {
        dtConsultation = getdt("select  Consultation.id_consultation,  patient.nom,patient.prenom,patient.cin,Consultation.maladie,Consultation.remarque,Consultation.dateConsultation from patient,Consultation where patient.Id_Patient=Consultation.id_patient and consultation.id_Consultation='" +ID + "'");
    }

    public void chargerConsultationParCinPatient(string CIN)
    {
        dtConsultation = getdt("select  Consultation.id_consultation,  patient.nom,patient.prenom,patient.cin,Consultation.maladie,Consultation.remarque,Consultation.dateConsultation from patient,Consultation where patient.Id_Patient=Consultation.id_patient and patient.cin='"+CIN+"' ");
    }

    public void chargerConsultationParNomPatient(string Nom)
    {
        dtConsultation = getdt("select  Consultation.id_consultation,  patient.nom,patient.prenom,patient.cin,Consultation.maladie,Consultation.remarque,Consultation.dateConsultation from patient,Consultation where patient.Id_Patient=Consultation.id_patient and patient.nom like'%" + Nom + "%' ");
    }

    public Patient getNomPrenomPatientByIDConsultation(int idConsultation)
    {
        Patient p;
        DataTable dt;
        dt = getdt("select patient.nom,patient.prenom from patient,Consultation where patient.Id_Patient=Consultation.id_patient and id_consultation='"+idConsultation+"'");
        p = new Patient(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString());
        return p;
    }

    public void UpdateMaladieConsultation(string NewMaladie,Int32 idCons)
    {
        SqlCommand cmd = new SqlCommand("update Consultation set maladie='"+NewMaladie+"' where id_Consultation='"+idCons+"'", user.Cn);
        User.Cn.Open();
        cmd.ExecuteNonQuery();
        user.Cn.Close();
    
    }
    public void UpdateRemarqueConsultation(string NewRemarque, Int32 idCons)
    {
        SqlCommand cmd = new SqlCommand("update Consultation set remarque='" + NewRemarque + "' where id_Consultation='" + idCons + "'", user.Cn);
        User.Cn.Open();
        cmd.ExecuteNonQuery();
        user.Cn.Close();

    }
    public void chargerConsultationParIDPatient(Int32 IdPatient)
    {
        dtConsultation = getdt("select  Consultation.id_consultation,  patient.nom,patient.prenom,patient.cin,Consultation.maladie,Consultation.remarque,Consultation.dateConsultation from patient,Consultation where patient.Id_Patient=Consultation.id_patient and patient.id_patient ='"+IdPatient+"' ");
    }


    public void chercherPatientParRefConsultation(string RefConsultation)
    {

        dtPatients = getdt("select patient.Id_Patient,nom,prenom,cin,sexe,tel,dateNaissance,ville,poids from patient,Consultation where patient.Id_Patient=Consultation.id_patient and Consultation.id_consultation='"+RefConsultation+"'");
    
    }
    public void chargerExamensBiologique()
    {
        dtExamenBiologique = getdt("select * from analyses");
    }

    public void AjouterAnalyse(string analyse)
    {
        if (user.Cn.State == ConnectionState.Open)
        {
            user.Cn.Close();
        }
        SqlDataReader dr;
        SqlCommand cmd1 = new SqlCommand("select * from analyses where analyse='" + analyse + "'", user.Cn);
        user.Cn.Open();
        dr = cmd1.ExecuteReader();
        if (dr.HasRows)
        {
            MessageBox.Show("Cet examen existe deja !");
            User.Cn.Close();
        }
        else
        {
            if (user.Cn.State == ConnectionState.Open)
            {
                user.Cn.Close();
            }

            SqlCommand cmd = new SqlCommand("insert into analyses values ('" + analyse + "')", user.Cn);
            User.Cn.Open();
            cmd.ExecuteNonQuery();
            user.Cn.Close();
            MessageBox.Show("Examen ajouté avec succes !");

        }

            
    }
  
    public void SupprimerAnalyse(string analyse)
    {
        // il faut  d'abord supp depuis la table analysesDemmandée

        SqlCommand cmd2 = new SqlCommand("delete analysesdemandees where analyse ='"+analyse +"' ",user.Cn);
        User.Cn.Open();
        cmd2.ExecuteNonQuery();
        user.Cn.Close();

        SqlCommand cmd = new SqlCommand("delete analyses where analyse='"+analyse+"'", user.Cn);
        User.Cn.Open();
        cmd.ExecuteNonQuery();
        user.Cn.Close();


    }
    public void ajouterExamenDemmande(string examenDemmande,Int32 idConsultation)
    {
        if (user.Cn.State==ConnectionState.Open)
        {
            user.Cn.Close();
        }
        SqlCommand cmd = new SqlCommand("insert into AnalysesDemandees values ('"+idConsultation+"','"+examenDemmande+"')", user.Cn);
        User.Cn.Open();
        cmd.ExecuteNonQuery();
        user.Cn.Close();
    }

    public void chargerExamensBiologiqueDemmande(Int32 idConsultation)
    {
        dtExamenDemmande = getdt("select * from AnalysesDemandees where id_Consultation='"+idConsultation+"'");
    }

    public void supprimerExamenDemmande(string examenDemmande, Int32 idConsultation)
    {
        if (user.Cn.State == ConnectionState.Open)
        {
            user.Cn.Close();
        }
        SqlCommand cmd = new SqlCommand("delete AnalysesDemandees where id_consultation='"+idConsultation+"' and analyse='"+examenDemmande+"'", user.Cn);
        User.Cn.Open();
        cmd.ExecuteNonQuery();
        user.Cn.Close();
    }

    public void HistoriqueMedicamentPourPatient(Int32 idPatient)
    {

        dtHistoriqueMedicament = getdt("select distinct(medicamentPrescri.medicament) from medicamentPrescri,Consultation where medicamentPrescri.id_consultation=Consultation.id_consultation and Consultation.id_patient='"+idPatient+"'");
    
    }
    public void HistoriqueExamenBiologiques(Int32 idPatient)
    {
        dtHistoriqueExamen = getdt("select  distinct (AnalysesDemandees.analyse) from AnalysesDemandees,Consultation where AnalysesDemandees.id_consultation=Consultation.id_consultation and Consultation.id_patient='"+idPatient+"'");
    
    }
    public void HistoriqueMaladies(Int32 idPatient)
    {
        dtHistoriqueMaladies = getdt("select  distinct (Consultation.maladie) from Consultation where Consultation.id_patient='"+idPatient+"'");
    
    }

    public void EnvoyerUnMessage(Message msg)
    {

        SqlCommand cmd = new SqlCommand("insert into message values ('"+msg.TextMessage+"','"+msg.EtatMessage+"','"+msg.Sender+"')",user.Cn);
        user.Cn.Open();
        cmd.ExecuteNonQuery();
        user.Cn.Close();
    
    }

        // pour la discussion instantané
    public string LireMessage()
    {
        string msg = null;

        DataTable dt;
        dt = user.Cabinet.getdt("select * from message");

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            msg = msg +" \r\n" +dt.Rows[i][0].ToString(); 
        }

        return msg;
    }


    public void chargerExamenRadiologique()
    {

        dtExamenRadiologique = getdt("select * from analyseradiologique");
    
    }

    public void AjouterExamenRadiologique(string examenRadio)
    {
        if (user.Cn.State == ConnectionState.Open)
        {
            user.Cn.Close();
        }
        SqlDataReader dr;
        SqlCommand cmd1 = new SqlCommand("select * from analyseradiologique where analyseradio='" + examenRadio + "'", user.Cn);
        user.Cn.Open();
        dr = cmd1.ExecuteReader();
        if (dr.HasRows)
        {
            MessageBox.Show("Cet examen existe deja !");
            User.Cn.Close();
        }
        else
        {
            if (user.Cn.State == ConnectionState.Open)
            {
                user.Cn.Close();
            }


            SqlCommand cmd = new SqlCommand("insert into analyseradiologique values ('" + examenRadio + "')", user.Cn);
            user.Cn.Open();
            cmd.ExecuteNonQuery();
            user.Cn.Close();
            MessageBox.Show("Examen ajouté avec succes !");

        } 
    
    
    }

   
    public void SupprimerExamenRadio(string radio)
    {
        // il faut  d'abord supp depuis la table radioDemmandée
        SqlCommand cmd2 = new SqlCommand("delete radiodemmande where analyseradio='"+radio+"'",user.Cn);
        User.Cn.Open();
        cmd2.ExecuteNonQuery();
        user.Cn.Close();

        SqlCommand cmd = new SqlCommand("delete analyseradiologique where analyseradio='" + radio + "'", user.Cn);
        User.Cn.Open();
        cmd.ExecuteNonQuery();
        user.Cn.Close();

    }

    public void chargerExamenRadioDemmande(Int32 idConsultation)
    {
        dtExamenRadioDemmandee = getdt("select analyseradio from radiodemmande where id_consultation='"+idConsultation+"'");
    }

    public void AjouterExamenRadioDemmande(string NameOfRadio,Int32 idConsultation)
    {
        if (user.Cn.State==ConnectionState.Open)
        {
            user.Cn.Close();
        }
        SqlCommand cmd = new SqlCommand("insert  into radiodemmande values ('"+idConsultation+"','"+NameOfRadio+"')",user.Cn);

        user.Cn.Open();
        cmd.ExecuteNonQuery();
        user.Cn.Close();
    
    }
    public void SupprimerExamenRadioDemmandee(string NameOfRadio,Int32 idConsultation)
    {
        if (user.Cn.State==ConnectionState.Open)
        {
            user.Cn.Close();
        }
        SqlCommand cmd = new SqlCommand("delete radiodemmande where id_consultation='"+idConsultation+"' and analyseradio='"+NameOfRadio+"'",user.Cn);
        user.Cn.Open();
        cmd.ExecuteNonQuery();
        user.Cn.Close();
    
    }

    public void HistoriqueExamenRadiologiques(Int32 idPatient)
    {
        dtHisoriqueExamenRadio = getdt("select  distinct (radiodemmande.analyseradio) from radiodemmande,Consultation where radiodemmande.id_consultation=Consultation.id_consultation and Consultation.id_patient='" + idPatient + "'");

    }



    public void chargerExamenEndoscopique()
    {

        dtExamensEndoscopiques= getdt("select * from examensEndoscopiques");

    }

    public void AjouterExamenEndoscopique(string examenEndo)
    {
        if (user.Cn.State == ConnectionState.Open)
        {
            user.Cn.Close();
        }

        SqlDataReader dr;
        SqlCommand cmd1 = new SqlCommand("select * from examensendoscopiques where examenendoscopique='" + examenEndo + "'", user.Cn);
        user.Cn.Open();
        dr = cmd1.ExecuteReader();
        if (dr.HasRows)
        {
            MessageBox.Show("Cet examen existe deja !");
            User.Cn.Close();
        }
        else
        {
            if (user.Cn.State == ConnectionState.Open)
            {
                user.Cn.Close();
            }


            SqlCommand cmd = new SqlCommand("insert into examensendoscopiques values ('" + examenEndo + "')", user.Cn);
            user.Cn.Open();
            cmd.ExecuteNonQuery();
            user.Cn.Close();
            MessageBox.Show("Examen ajouté avec succes !");

        }



    }
    public void SupprimerExamenEndoscopique(string endoscopie)
    {
        // il faut  d'abord supp depuis la table radioDemmandée
        SqlCommand cmd2 = new SqlCommand("delete examensendoscopiquesdemmandees where examenendoscopiquedemmande='" + endoscopie + "'", user.Cn);
        User.Cn.Open();
        cmd2.ExecuteNonQuery();
        user.Cn.Close();

        SqlCommand cmd = new SqlCommand("delete examensendoscopiques where examenendoscopique='" + endoscopie + "'", user.Cn);
        User.Cn.Open();
        cmd.ExecuteNonQuery();
        user.Cn.Close();

    }

    public void chargerExamenEndoscopiqueDemmande(Int32 idConsultation)
    {
        dtExamenEndoscopiqueDemmande = getdt("select examenendoscopiquedemmande from examensendoscopiquesdemmandees where id_consultation='" + idConsultation + "'");
    }

    public void SupprimerExamenEndoscopiqueDemmandee(string NameOfEndoscopie, Int32 idConsultation)
    {
        if (user.Cn.State == ConnectionState.Open)
        {
            user.Cn.Close();
        }
        SqlCommand cmd = new SqlCommand("delete examensendoscopiquesdemmandees where id_consultation='" + idConsultation + "' and examenendoscopiquedemmande='" + NameOfEndoscopie + "'", user.Cn);
        user.Cn.Open();
        cmd.ExecuteNonQuery();
        user.Cn.Close();

    }

    public void AjouterExamenEndoscopiqueDemmande(string NameOfEndoscopie, Int32 idConsultation)
    {
        if (user.Cn.State == ConnectionState.Open)
        {
            user.Cn.Close();
        }
        SqlCommand cmd = new SqlCommand("insert  into examensendoscopiquesdemmandees values ('" + idConsultation + "','" + NameOfEndoscopie + "')", user.Cn);

        user.Cn.Open();
        cmd.ExecuteNonQuery();
        user.Cn.Close();

    }

    public void HistoriqueExamenEndoscopique(Int32 idPatient)
    {
        dtHitoriqueExamenEndoscopique = getdt("select  distinct (examensendoscopiquesdemmandees.examenendoscopiquedemmande) from examensendoscopiquesdemmandees,Consultation where examensendoscopiquesdemmandees.id_consultation=Consultation.id_consultation and Consultation.id_patient='" + idPatient + "'");

    }


    public void chargerExamenAnatomo()
    {

        dtExamenAnatomo = getdt("select * from examensanatomo");

    }

    public void AjouterExamenAnatomo(string examenAnatomo)
    {
        if (user.Cn.State == ConnectionState.Open)
        {
            user.Cn.Close();
        }
        SqlDataReader dr;
        SqlCommand cmd1 = new SqlCommand("select * from examensanatomo where anatomo='" + examenAnatomo + "'", user.Cn);
        user.Cn.Open();
        dr = cmd1.ExecuteReader();
        if (dr.HasRows)
        {
            MessageBox.Show("Cet examen existe deja !");
            User.Cn.Close();
        }
        else
        {
            if (user.Cn.State == ConnectionState.Open)
            {
                user.Cn.Close();
            }


            SqlCommand cmd = new SqlCommand("insert into examensanatomo values ('" + examenAnatomo + "')", user.Cn);
            user.Cn.Open();
            cmd.ExecuteNonQuery();
            user.Cn.Close();
            MessageBox.Show("Examen ajouté avec succes !");


        }




    }

    public void SupprimerExamenAnatomo(string anatomo)
    {
        // il faut  d'abord supp depuis la table anatomodemmandes
        SqlCommand cmd2 = new SqlCommand("delete examensanatomodemmandes where anatomo='" + anatomo + "'", user.Cn);
        User.Cn.Open();
        cmd2.ExecuteNonQuery();
        user.Cn.Close();

        SqlCommand cmd = new SqlCommand("delete examensanatomo where anatomo='" + anatomo + "'", user.Cn);
        User.Cn.Open();
        cmd.ExecuteNonQuery();
        user.Cn.Close();

    }
    public void chargerExamenAnatomoDemmande(Int32 idConsultation)
    {
        dtExamenAnatomoDemmande = getdt("select anatomo from examensanatomodemmandes where id_consultation='" + idConsultation + "'");
    }

  

    public void AjouterExamenAnatomoDemmande(string NameOfAnatomo, Int32 idConsultation)
    {
        if (user.Cn.State == ConnectionState.Open)
        {
            user.Cn.Close();
        }
        SqlCommand cmd = new SqlCommand("insert  into examensanatomodemmandes values ('" + idConsultation + "','" + NameOfAnatomo + "')", user.Cn);

        user.Cn.Open();
        cmd.ExecuteNonQuery();
        user.Cn.Close();

    }
    public void SupprimerExamenAnatomoDemmandee(string NameOfAnatomo, Int32 idConsultation)
    {
        if (user.Cn.State == ConnectionState.Open)
        {
            user.Cn.Close();
        }
        SqlCommand cmd = new SqlCommand("delete examensanatomodemmandes where id_consultation='" + idConsultation + "' and anatomo='" + NameOfAnatomo + "'", user.Cn);
        user.Cn.Open();
        cmd.ExecuteNonQuery();
        user.Cn.Close();

    }

    public void HistoriqueExamenAnatomo(Int32 idPatient)
    {
        dtHistoriqueExamenAnatomo = getdt("select  distinct (examensanatomodemmandes.anatomo) from examensanatomodemmandes,Consultation where examensanatomodemmandes.id_consultation=Consultation.id_consultation and Consultation.id_patient='" + idPatient + "'");

    }


    public void chargerLastEvolutions()
    {
        dtEvolution = getdt("  select * from EvolutionST where id_evo='"+user.Cabinet.CurrentEvolution.IdEvolution+"' and id_cons='"+user.Cabinet.CurrentEvolution.IdConsultation+"'");
    
    }

    public void chargerLastEvolutionWithAllConsultation(Int32 idLastEvo)
    {
        dtEvolution = getdt("select  * from EvolutionST where id_Evo='"+idLastEvo+"'");
    }

    public Int32 getLastConsultationIdForThePatient(Int32 idPatient)
    {
        if (user.Cn.State==ConnectionState.Open)
        {
            user.Cn.Close();
        }

        Int32 idCon;
        SqlCommand cmd = new SqlCommand("select top 1  * from Consultation where id_patient='"+idPatient+"' order by id_consultation desc", user.Cn);
        user.Cn.Open();
        idCon = Int32.Parse(cmd.ExecuteScalar().ToString());
        user.Cn.Close();

        return idCon;
    
    }
    public void chargerConsultation(Int32 idConsultation)
    {
        dtConsultation = getdt("select * from consultation where id_consultation='"+idConsultation+"'");
    }

    public string chargerStateRoleMedicamentPourMedcin()
    {
        string state = null;
        if (user.Cn.State==ConnectionState.Open)
        {
            user.Cn.Close();
        }
        SqlCommand cmd = new SqlCommand("select state from roles where utilisateur ='medcin' and role='medicament'",user.Cn);
        user.Cn.Open();
        state = cmd.ExecuteScalar().ToString();
        user.Cn.Close();

        return state;
    }

    public string chargerStateRoleMedicamentPourSecretaire()
    {
        string state = null;
        if (user.Cn.State == ConnectionState.Open)
        {
            user.Cn.Close();
        }
        SqlCommand cmd = new SqlCommand("select state from roles where utilisateur ='secretaire' and role='medicament'", user.Cn);
        user.Cn.Open();
        state = cmd.ExecuteScalar().ToString();
        user.Cn.Close();

        return state;
    }

    public void updateStateRoleMedicamentForMedcin(string newstate)
    {
        if (user.Cn.State == ConnectionState.Open)
        {
            user.Cn.Close();
        }
        SqlCommand cmd = new SqlCommand("update roles set state='"+newstate+"' where utilisateur='medcin' and role='medicament'", user.Cn);
        user.Cn.Open();
        cmd.ExecuteNonQuery();
        user.Cn.Close();

    }
    public void updateStateRoleMedicamentForSecretaire(string newstate)
    {
        if (user.Cn.State == ConnectionState.Open)
        {
            user.Cn.Close();
        }
        SqlCommand cmd = new SqlCommand("update roles set state='" + newstate + "' where utilisateur='secretaire' and role='medicament'", user.Cn);
        user.Cn.Open();
        cmd.ExecuteNonQuery();
        user.Cn.Close();

    }


    }
}
