using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cliente : MonoBehaviour {
	private List<Producto> p;
	// Use this for initialization
	void Start () {
		p = new List<Producto>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void añadir(string n){
		Producto prod = new Producto (n);
		p.Add (prod);
	}
	public string mostrar(){
		string aux = "";
		for (int i = 0; i < p.Count; i++) {
			aux = aux + p[i].nombre+ "\n";
		}
		return aux;
	}
}

public class Producto{
	public string nombre;
	public Producto(string n){
		nombre = n;
	}
}
