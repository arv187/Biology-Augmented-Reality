using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FamilyPolicyWarning : MonoBehaviour
{
    [SerializeField] Canvas policyMessage;

    public void OkButton()
    {
        // Desactiva el mensaje de advertencia PolicyMessage
        policyMessage.enabled = false;
        // Llama al m�todo para activar el bot�n de salida
        ExitButton.Instance.ShowExitButton();
    }
}
