using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreData {

	static string stored_message;
	static public string messages { get { return stored_message; } set { stored_message = value; } }
}
