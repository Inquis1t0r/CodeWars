public class FindOdd {
	public static int findIt(int[] A) {
  int odd = 0, i = 0;
 
 //TODO: check and refactor
 
  while(i < A.length){
     if(A[i] % 2 == 1){
        odd = A[i];
        }
     i++;
     }
   return odd;
  }
  
}
