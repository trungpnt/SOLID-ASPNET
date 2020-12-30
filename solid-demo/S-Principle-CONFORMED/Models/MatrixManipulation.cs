namespace S_Principle_CONFORMED.Models
{
    public class MatrixManipulation {
        private SquaredMatrix squaredMatrix;
        public SquaredMatrix initMatrix(int sz) {
            SquaredMatrix squaredMatrix = new SquaredMatrix(sz);
            for (int i = 0; i < sz; i++) {
                for (int j = 0; j < sz; j++) {
                    //("Please enter each element !");
                }
            }
            this.squaredMatrix = squaredMatrix;
            return this.squaredMatrix;
        }

        public void sort(SquaredMatrix a){
            int[] temp = new int[3];
            int[][] elements = a.getElements();
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
        }

        public void print(SquaredMatrix a){
                for (int i = 0; i < a.getSize(); i++) {
                    for (int j = 0; j < a.getSize(); j++){
                        //(a[i][j] + " ");
                }
            }
        }
    }
}