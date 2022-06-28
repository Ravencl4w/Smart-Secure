package SmartSecure.example.EVA.services;

import java.util.List;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import SmartSecure.example.EVA.models.Condominios;
import SmartSecure.example.EVA.repositories.CondominiosRepository;

@Service
public class CondominiosService {

    @Autowired
    private CondominiosRepository condominiosRepository;

    public Condominios create (Condominios condominios) {
        return condominiosRepository.save(condominios);
    }

    public List<Condominios> getAllPlans() {
       return condominiosRepository.findAll();
    }

   public void delete (Condominios condominios) {
    condominiosRepository.delete(condominios);
   }

   public Optional<Condominios> findById (Long id) {
    return condominiosRepository.findById(id);
   }
   public void NotificarResidentes(){
     
    System.out.println("Se ha avistado un sospechoso");
    System.out.println("Mostrando foto...... -> **FOTO**");
    GenerarVotacion();
    if (GenerarVotacion() == true){
        LlamarAutoridades();
    }
    
    
   }
   public boolean GenerarVotacion() {
    System.out.println("Generando votación:");
    System.out.println("Conoce a la persona de la foto SI/NO:");
    System.out.println("Usted escogio la opción: NO");
    System.out.println("Enviando notificación a todos los usuarios.......");
    return true;
    
   }
   public void LlamarAutoridades(){
    System.out.println("Llamando a la policia.......");
    System.out.println("Denuncia ejecutada con exito.......");
   }
   
}
