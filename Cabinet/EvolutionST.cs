using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cabinet
{
    public class EvolutionST
    {
        private Int32 idEvolution;       
        private string state; 
        private Int32 idConsultation;
        private DateTime dateControl;
        private int idPatient;

        public int IdPatient
        {
            get { return idPatient; }
            set { idPatient = value; }
        }

        public Int32 IdEvolution
        {
            get { return idEvolution; }
            set { idEvolution = value; }
        }
        public Int32 IdConsultation
        {
            get { return idConsultation; }
            set { idConsultation = value; }
        }
       
        public string State
        {
            get { return state; }
            set { state = value; }
        }
       
        public DateTime DateControl
        {
            get { return dateControl; }
            set { dateControl = value; }
        }

        public EvolutionST()
        { }

        public EvolutionST(Int32 idCons,Int32 idEvo,Int32 idPatien, string state,DateTime dateCont )
        {
            this.IdConsultation = idCons;
            this.IdEvolution = idEvo;
            this.IdPatient = idPatien;
            this.State = state;
            this.DateControl = dateCont;
        
        
        }
    }
}
