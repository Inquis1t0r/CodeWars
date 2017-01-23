public class DnaStrand {
  public static String makeComplement(String dna) {
  StringBuilder replaced = new StringBuilder();
    
    for(int i=0;i<dna.length();i++)
    {
      if(dna.charAt(i) == 'C'){
      replaced.append("G");
      }
      else if(dna.charAt(i) == 'G'){
      replaced.append("C");
      }
      else if(dna.charAt(i) == 'T'){
      replaced.append("A");
      }
      else 
      replaced.append("T");{
      }
    }
  
return replaced.toString();
  }  
}
