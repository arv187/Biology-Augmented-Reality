using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FamilyPolicyWarning : MonoBehaviour
{
    [SerializeField] Canvas policyMessage;
    [SerializeField] GameObject canvasExitButton; // Referencia al CanvasExitButton

    public void OkButton()
    {
        // Desactiva el mensaje de advertencia PolicyMessage
        policyMessage.enabled = false;
<<<<<<< Updated upstream
        // Llama al m�todo para activar el bot�n de salida
        ExitButton.Instance.ShowExitButton();
=======
        // Activa el CanvasExitButton
        canvasExitButton.SetActive(true);
>>>>>>> Stashed changes
    }
}
