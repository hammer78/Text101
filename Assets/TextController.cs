using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	public Text text;
	
	private enum State {cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, freedom};
	private State myState;
	
	// Use this for initialization
	void Start () {
		myState = State.cell;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
			if (myState == State.cell) {state_cell ();} 
			else if (myState == State.sheets_0) 	{state_sheets_0();} 
			else if (myState == State.lock_0) 		{state_lock_0();}
			else if (myState == State.mirror)		{state_mirror();}
			else if (myState == State.cell_mirror)	{state_cell_mirror();}
			else if (myState == State.sheets_1)		{state_sheets_1();}
			else if (myState == State.lock_1)		{state_lock_1();}
			else if (myState == State.freedom)		{state_freedom();}
	}
	//roaming the cell
	void state_cell(){
		text.text = "You are in a prison cell, convicted of a murder that you did not " +
					"commit! You need to escape to find the person that killed the man in black. " +
					"As you look around you see some dirty sheets on the bed, a mirror on the wall, " +
					"and the door is locked from the outside.\n\n" +
					"Press S to view Sheets, M to view Mirror, or L to view Lock";
		
		if (Input.GetKeyDown(KeyCode.S)) {
			myState = State.sheets_0;
			
		}
	}
	
	void state_sheets_0(){
		text.text = "The sheets smell foul and dirty! You know you have been in here for " +
					"a long time, but as you put the sheets to your nose, you know it has been " +
					"too long, and it is time to get out!\n\n" +
					"Press R to Return to roaming your cell";
		
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = State.cell;
			
		}
	}
	
	void state_lock_0(){
		text.text = "You walk to the cell door and look at the lock, but you don't have " +
					"anything to open it with. You curse in dispear. You think back to your first " +
					"meeting with the man in black!\n\n" +
					"Press R to Return to roaming your cell";
		
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = State.cell;
			
		}
	}
}
