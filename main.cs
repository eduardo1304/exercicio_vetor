using System;

class MainClass {
  public static void Main (string[] args) {
    
     
     
     int[] vetor1 = new int[]{1,2,3,4,5};
     int[] vetor2 = new int[]{2,4,6,8,10,12,1,5};


     

      for (int i=0; i<vetor1.Length; i++){

        for(int j=0; j<vetor2.Length; j++){            
        if (vetor1[i] == vetor2[j]){
          Console.Write("{0}, ", vetor1[i]); 
        }
                  
        }  
      }

      



  }
}