package SmartSecure.example.EVA.services;

import java.util.List;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import SmartSecure.example.EVA.models.Personas;
import SmartSecure.example.EVA.repositories.PersonasRepository;

@Service
public class PersonaService {
    @Autowired
    private PersonasRepository personasRepository;

     //CREAR PERSONA CON TAG DE SOSPECHOSO
    public Personas create (Personas personas) {
        return personasRepository.save(personas);
    }

    public List<Personas> getAllPlans() {
       return personasRepository.findAll();
    }

   public void delete (Personas personas) {
    personasRepository.delete(personas);
   }

   public Optional<Personas> findById (Long id) {
    return personasRepository.findById(id);
   }
   public void AnalizarFoto() {

    System.out.println("Analizando foto de la nueva persona...........");
    if (persona.tag == "sospechoso")
    {
        System.out.println("Se ha detectado un sospechoso");
    }
   }
   
}
