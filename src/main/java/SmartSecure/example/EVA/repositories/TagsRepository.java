package SmartSecure.example.EVA.repositories;

import org.springframework.data.jpa.repository.JpaRepository;

import SmartSecure.example.EVA.models.Tags;

public interface TagsRepository extends JpaRepository<Tags,Long> {
    
}
