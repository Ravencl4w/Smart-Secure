package SmartSecure.example.EVA.repositories;

import org.springframework.data.jpa.repository.JpaRepository;

import SmartSecure.example.EVA.models.Personas;

public interface PersonasRepository extends JpaRepository<Personas,Long> {
    
}
