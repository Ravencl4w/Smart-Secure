package SmartSecure.example.EVA.repositories;

import org.springframework.data.jpa.repository.JpaRepository;

import SmartSecure.example.EVA.models.Contactos;

public interface ContatosRepository extends JpaRepository<Contactos, Long>{
    
}
