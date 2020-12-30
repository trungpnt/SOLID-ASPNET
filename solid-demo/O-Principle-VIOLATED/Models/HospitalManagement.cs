namespace D_Principle_VIOLATED.Models
{
    public class HospitalManagement
    {
        //This class is forced to contain all kinds of behaviors which should belong to the
    //HospitalStaff.COVID19Fighter class, and each fighter's behavior should only be carried out by each
    //fighter objects
    public void callUpon(Covid19Fighter covid19Fighter){
        //If this class is required to support the work done by the CEO or another department
        //These conditionals with "instance of" will be messy
        if( covid19Fighter is Nurse){
            checkVitalSigns();
            drawBlood();
            cleanPatientArea();
        }
        if(covid19Fighter is SecurityGuard){
            coordinateVehicle();
            takeBodyTemperature();
        }
    }
    //This class also knows too much about what nurses and guards are doing, and in the future
    //it will know all duties of many other employees in the hospital
    //So it violates OCP principle

    //HospitalStaff.Nurse
    private void checkVitalSigns(){
        //output ("Checking...");
    }
    private void drawBlood(){
        //output("drawing Blood");
    }
    private void cleanPatientArea(){
        //output("Cleaning....");
    }
    //Guard
    private void coordinateVehicle(){
        //output("Coordinating...");
    }
    private void takeBodyTemperature(){
        //output("taking...");
    }
    }
}