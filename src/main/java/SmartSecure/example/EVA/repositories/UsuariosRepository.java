package SmartSecure.example.EVA.repositories;

import org.springframework.data.jpa.repository.JpaRepository;

import SmartSecure.example.EVA.models.Usuarios;

public interface UsuariosRepository extends JpaRepository<Usuarios,Long>{
    
}