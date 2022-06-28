package SmartSecure.example.EVA.controllers;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import SmartSecure.example.EVA.services.CondominiosService;
import SmartSecure.example.EVA.services.PersonaService;

@RestController
@RequestMapping ("api/condominios")
public class CondominioController {
    @Autowired
    private CondominiosService condominiosService;
    @Autowired
    private PersonaService personaService;
    @GetMapping
    public void CameraFunction(){
        personaService.AnalizarFoto();
        condominiosService.NotificarResidentes();
    }
    
}
