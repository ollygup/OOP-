using System;

namespace PassTask3{

    //enumeration for patient type
    public enum PatientType{
        InPatient, Outpatient
    }

    //enumeration for severity level
    public enum SeverityLevel{
        High, Medium, Low
    }


    public class Patient{
        private string _name;
        private int _id;
        private string _docInCharge;
        private PatientType _type;
        private SeverityLevel _severity;
        private int _charges;
        private string _diagnosis;

        public Patient(string name, int id, string doctor, PatientType type, SeverityLevel severity, int charges, string diagnosis){
            _name = name;
            _id = id;
            _docInCharge = doctor;
            _type = type;
            _severity = severity;
            _charges = charges;
            _diagnosis = diagnosis;
        }

        //property for name
        public string Name{
            get { return _name; }
            set { _name = value; }
        }

        //property for ID
        public int Id{
            get { return _id; }
            set { _id = value; }
        }

        //property for Doctor in charge
        public string DocInCharge{
            get { return _docInCharge; }
            set { _docInCharge = value; }
        }

        //read only property for Charges
        public int Charges{
            get { return _charges; }
        }


        //read only property for Diagnosis
        public string Diagnosis{
            get { return _diagnosis; }
        }

        //property for PatientType type (a custom type created using enum)
        public PatientType Type{
            get { return _type; }
            set { _type = value; }
        }

        //property for SeverityLevel severity ( a custom type created using enum)
        public SeverityLevel Severity{
            get { return _severity; }
            set { _severity = value; }
        }
        
        //a method called listdetails that does the comparison depending on what 
        //type and severity the patient is and return a custom message
        public string ListDetails(){
            if ( _type == (PatientType)0 ){
               return "Additional charges based on the duration of hospital stays.";
            }else if ( _type == (PatientType)1 && ( _severity == (SeverityLevel)0 ) ){
                return "Additional charges based on the duration of hospital stays.";
            }else if ( _type == (PatientType)1 && ( _severity == (SeverityLevel)1 ) ){
                return "Please refer to medical doctor for more information.";
            }else{
                return "Please complete the medication given.";
            }

        }

    }   
}

