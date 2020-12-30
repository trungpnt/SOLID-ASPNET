namespace S_Principle_CONFORMED.Models
{
    public class SquaredMatrix {
            private int size;
            
            public int getSize()
            { 
                return size;
            }
            private int[][] elements;

            public int[][] getElements()
            {
                return elements;
            }
            
            public SquaredMatrix(){
                size = 0;
            }

            public SquaredMatrix(int sz) {
                size = sz;
            }

            public int getElementAtIndexes(int rowIndex, int colIndex){
                return elements[rowIndex][colIndex];
            }

            public void setElementAtIndexes(int rowIndex, int colIndex, int value){
                elements[rowIndex][colIndex] = value;
            }

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
                return res;
            }
    }
}
