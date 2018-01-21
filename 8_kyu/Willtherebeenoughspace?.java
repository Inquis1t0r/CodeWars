public class Bob {
  public static int enough(int cap, int on, int wait){
  int sumOfPassengers = on + wait;
  
  if(sumOfPassengers > cap)
  return Math.abs(sumOfPassengers - cap);
  else
  return 0;
  
  }
}
