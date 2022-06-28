package SmartSecure.example.EVA.controllers;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import SmartSecure.example.EVA.services.CondominiosService;

@RestController
@RequestMapping ("api/condominios")
public class CondominioController {
    @Autowired
    private CondominiosService condominiosService;

    @GetMapping
    private void Notificacion() {

        System.out.println("Se ha detectado un sospechoso");
        System.out.println("Iniciar votación");
        System.out.println("**FOTO** ¿Esta persona es sospechosa?: SI/NO");
        System.out.println("Usted escogio la opción: SI");
        System.out.println("Enviando notificación a todos los usuarios.......");
        System.out.println("Llamando a la policia.......");
        System.out.println("Denuncia ejecutada con exito.......");
    }
    
}
