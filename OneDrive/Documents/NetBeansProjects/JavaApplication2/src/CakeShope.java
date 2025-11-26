/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author talaF
 */
public class CakeShope {


public abstract class CakeStore{
    
public Cake OrderCake(String type){
  Cake cake=CreateCake(type);
    return cake;
}
 public abstract Cake CreateCake(String type);
}
public class StandardCakeStore extends CakeStore { 
    @Override
    public Cake CreateCake(String type) {

        if (type.equalsIgnoreCase("apple")) {
            return new AppleCake();
        } else if (type.equalsIgnoreCase("cheese")) {
            return new CheeseCake();
        } else if (type.equalsIgnoreCase("chocolate")) {
            return new ChocolateCake();
        }

        throw new IllegalArgumentException("Unknown cake type: " + type);
    }
}


public abstract class Cake{
    String description="Unknown Cake";
   public String getDescription(){
       return description;
        
    }
 public abstract double cost();
    
}
 public  class AppleCake extends Cake{
    
    public AppleCake(){
        description="Apple Cake";
    }
    

    @Override
    public double cost() {
      return 15.0;
        }
    
}
 public  class ChocolateCake extends Cake {
        public ChocolateCake() { description = "Chocolate Cake"; }
        public double cost() { return 18.0; }
    }

    public  class CheeseCake extends Cake {
        public CheeseCake() { description = "Cheese Cake"; }

        @Override
        public double cost() {
            return 30.0;
        }
    }
    public abstract class CondementDecorator extends Cake{
        
    public abstract String getDescription();
}
    public class Cream extends CondementDecorator{
        Cake cake;
        public Cream(Cake cake){
            cake=this.cake;
        }

        @Override
        public String getDescription() {
            return cake.getDescription()+",Cream ";
        }

        @Override
        public double cost() {
            return cake.cost()+3.0;
        }
        
        
    }
    
     public class Skittles extends CondementDecorator{
        Cake cake;
        public Skittles(Cake cake){
            cake=this.cake;
        }

        @Override
        public String getDescription() {
            return cake.getDescription()+",Skittles ";
        }

        @Override
        public double cost() {
            return cake.cost()+5.0;
        }   
    }
     public class ChocolateChips extends CondementDecorator{
        Cake cake;
        public ChocolateChips(Cake cake){
            cake=this.cake;
        }

        @Override
        public String getDescription() {
            return cake.getDescription()+",ChocolateChips ";
        }

        @Override
        public double cost() {
            return cake.cost()+7.0;
        }   
    }
     
    public interface  Subject{
        
    }
     
     
     

 public static void main(String[] args) {
            
        }
    
}
