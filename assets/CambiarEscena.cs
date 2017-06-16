using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour {

    public void escena1()
    {
            SceneManager.LoadScene("listaproducots");

    }

	public void escenaTienda()
	{
		SceneManager.LoadScene("tienda");

	}

	public void escenaRegistro()
	{
		SceneManager.LoadScene("MenuRegistro");
	}

	public void escenaLogin()
	{
		SceneManager.LoadScene("MenuLogin");

	}
}
