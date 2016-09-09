using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextAreaView : MonoBehaviour {

	private InputField AreaText;

	private string _currentText;
	public string currentText {
		get { return _currentText;}
		set { 
			_currentText = value;
			AreaText.text = _currentText;
		}
	} 

	// Use this for initialization
	void Awake () {
		AreaText = GetComponent<InputField> ();
		Reset ();
	}

	public void SendString(string value){
		currentText += "Sent: "+value+ "\n";
	}


	public void RecvString(string value){
		currentText += value+ "\n";
	}

	public void Reset(){
		currentText = string.Empty;
	}
}
