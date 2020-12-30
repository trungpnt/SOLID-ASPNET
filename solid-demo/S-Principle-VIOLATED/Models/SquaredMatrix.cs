using System;

namespace S_Principle_VIOLATED.Models
{
    public class SquaredMatrix {

        public int size;
        public int[][] elements;
        
        SquaredMatrix(){
            size = 0;
        }

        SquaredMatrix(int sz) {
            size = sz;
        }

        //This method should also be handed to another class !
        public SquaredMatrix initMatrix(int sz) {
            SquaredMatrix squaredMatrix = new SquaredMatrix(sz);
            for (int i = 0; i < sz; i++) {
                for (int j = 0; j < sz; j++) {
                    //("Please enter each element !");
                    //elements.add..;
                }
            }
            return squaredMatrix;
        }

        public int getElementAtIndexes(int rowIndex, int colIndex){
            return elements[rowIndex][colIndex];
        }

        public void setElementAtIndexes(int rowIndex, int colIndex, int value){
            elements[rowIndex][colIndex] = value;
        }

        // the problem starts here
        public SquaredMatrix multiplyMatrix( SquaredMatrix b) {
            SquaredMatrix res = new SquaredMatrix(size);
            for (int i = 0; i < size; i++) {
                for (int j = 0; j < size; j++) {
                    res.setElementAtIndexes(i, j, 0);
                    for (int k = 0; k < size; k++) {
                        int x = this.getElementAtIndexes(i, j) * b.getElementAtIndexes(i, j);
                        res.setElementAtIndexes(i, j, x);
                    }
                }
            }

            //this method shouldn't be responsible for sorting!

            
            int[] temp = new int[3];

            for (int i = 0; i < elements.GetLength(0) - 1; i++){
                int j;
                j = 0;
                for (; j < elements.GetLength(0) - 1; j++){

                    if (elements[j][2] > elements[j + 1][2]){
                        //make a swap
                        //put array record j into temp holder
                        temp[0] = elements[j][0];
                        temp[1] = elements[j][1];
                        temp[2] = elements[j][2];

                        //copy j + 1 into j
                        elements[j][0] = elements[j + 1][0];
                        elements[j][1] = elements[j + 1][1];
                        elements[j][2] = elements[j + 1][2];

                        //copy temp into j + 1
                        elements[j + 1][0] = temp[0];
                        elements[j + 1][1] = temp[1];
                        elements[j + 1][2] = temp[2];

                    }
                }
            }
            

            //this method shouldn't be responsible for printing !
            for (int i = 0; i < size; i++) 
            {
                for (int j = 0; j < size; j++)
                {
                    System.Console.WriteLine(elements[i][j]);
                }
            }

            return res;
        }

}
}

