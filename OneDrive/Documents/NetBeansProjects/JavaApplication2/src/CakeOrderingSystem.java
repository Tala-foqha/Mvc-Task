
import java.util.ArrayList;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author talaF
 */
public class CakeOrderingSystem implements Subject {
    private ArrayList observers;
    public CakeOrderingSystem(){
    observers =new ArrayList();
    }

    @Override
    public void registerObserver(Observer o) {
        observers.add(o);
        
        
    }

    @Override
    public void removeObserver(Observer o) {
        
    }

    @Override
    public void notifyObservers(Observer o) {
    }
    
}
