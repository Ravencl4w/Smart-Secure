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
   
}
