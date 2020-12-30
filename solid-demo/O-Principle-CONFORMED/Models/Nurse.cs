namespace O_Principle_CONFORMED.Models
{
    public class Nurse : COVID19Fighter{
        
        private void checkVitalSigns(){
            //("Checking...");
        }
        private void drawBlood(){
            //("drawing Blood");
        }
        private void cleanPatientArea(){
            //("Cleaning....");
        }
        public void doDuties() {
            checkVitalSigns();
            drawBlood();
            cleanPatientArea();
        }

       
    }
}


