package SmartSecure.example.EVA.models;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.Table;

import lombok.Data;

@Data
@Entity
@Table(name = "Contantos")
public class Contactos {

    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    @Column(name = "id", nullable = false)
    private Long id;
    @Column(name = "email", nullable = true)
    private String email;
    @Column(name = "phoneNumber", nullable = false)
    private String phoneNumber;
    @Column(name = "name", nullable = false)
    private String name;

}
