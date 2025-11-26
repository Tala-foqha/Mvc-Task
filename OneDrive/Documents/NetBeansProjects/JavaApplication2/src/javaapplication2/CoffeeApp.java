package javaapplication2;
public class CoffeeApp {
// الفئة الأساسية التي تمثل أي نوع من القهوة
public abstract class Beverage {
    String description = "Unknown Beverage";

    public String getDescription() {
        return description;
    }

    public abstract double cost();
}

// فئة تمثل نوع قهوة Espresso
class Espresso extends Beverage {

    public Espresso() {
        description = "Espresso";
    }

    @Override
    public double cost() {
        return 1.99;
    }
}
// فئة التجريب (فيها الـ main)public class CoffeeApp {
    public static void main(String[] args) {

        Beverage beverage1 = new Espresso();
        System.out.println(beverage1.getDescription() + " $" + beverage1.cost());
    }}

