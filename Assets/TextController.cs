using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	public Text text;
	
	private enum State {
		cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, cell_1, corridor_0,
		stairs_0, floor, closet_door, stairs_1, corridor_1, in_closet_0, corridor_2, 
		corridor_3, courtyard, in_closet_1
		};
	private State myState;
	
	// Use this for initialization
	void Start () {
		myState = State.cell;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
			if 		(myState == State.cell) 		{cell ();} 
			else if (myState == State.sheets_0) 	{sheets_0();} 
			else if (myState == State.lock_0) 		{lock_0();}
			else if (myState == State.mirror)		{mirror();}
			else if (myState == State.cell_mirror)	{cell_mirror();}
			else if (myState == State.sheets_1)		{sheets_1();}
			else if (myState == State.lock_1)		{lock_1();}
			else if (myState == State.cell_1)		{cell_1();}
			else if (myState == State.corridor_0)	{corridor_0();}
			else if (myState == State.stairs_0)		{stairs_0();}
			else if (myState == State.floor)		{floor();}
			else if (myState == State.closet_door)	{closet_door();}
			else if (myState == State.stairs_1)		{stairs_1();}
			else if (myState == State.corridor_1)	{corridor_1();}
			else if (myState == State.in_closet_0)	{in_closet_0();}
			else if (myState == State.in_closet_1)	{in_closet_1();}		
			else if (myState == State.corridor_2)	{corridor_2();}
			else if (myState == State.corridor_3)	{corridor_3();}
			else if (myState == State.courtyard)	{courtyard();}
		
			}
	//roaming the cell
	void cell(){
		text.text = "You are in a prison cell, convicted of a murder that you did not " +
					"commit! You need to escape to find the person that killed the man in black. " +
					"As you look around you see some dirty sheets on the bed, a mirror on the wall, " +
					"and the door is locked from the outside.\n\n" +
					"Press S to view Sheets, M to view Mirror, or L to view Lock";
		
			if 		(Input.GetKeyDown(KeyCode.S)) 		{myState = State.sheets_0;}
			else if (Input.GetKeyDown(KeyCode.M))		{myState = State.mirror;}
			else if (Input.GetKeyDown(KeyCode.L))		{myState = State.lock_0;}
		
		
	}
	
	void cell_1(){
		text.text = "You walk around the cell with the key in your hand and wonder why you would be "+
					"in here for the murder of the man in black. All you remember is he was a nice person "+
					"but all other memories are few and far between.\n\n"+
					"Press S to view Sheets, M to view Mirror, or L to view Lock";
			if 		(Input.GetKeyDown(KeyCode.S)) 		{myState = State.sheets_1;}
			else if (Input.GetKeyDown(KeyCode.M))		{myState = State.cell_mirror;}
			else if (Input.GetKeyDown(KeyCode.L))		{myState = State.lock_1;}
		}
	
	void sheets_0(){
		text.text = "The sheets smell foul and dirty! You know you have been in here for " +
					"a long time, but as you put the sheets to your nose, you know it has been " +
					"too long, and it is time to get out!\n\n" +
					"Press R to Return to roaming your cell";
		
			if 		(Input.GetKeyDown(KeyCode.R)) 		{myState = State.cell;}
	}
	
	void lock_0(){
		text.text = "You walk to the cell door and look at the lock, but you don't have " +
					"anything to open it with. You curse in dispear. You think back to your first " +
					"meeting with the man in black!\n\n" +
					"Press R to Return to roaming your cell";
		
			if 		(Input.GetKeyDown(KeyCode.R))		 {myState = State.cell;}
	}
	
	void mirror(){
		text.text = "As you move towards the mirror, you see that there is no reflection due "+
					"to the dirt covering the mirror, but you pay not attention to that because "+
					"you see something poking out of the bottom of it.  As you look closer, it is a KEY!\n\n" +
					"Press T to Take the key!";
		
			if 		(Input.GetKeyDown(KeyCode.T))		{myState = State.cell_1;}
	}
	
	void cell_mirror(){
		text.text = "You don't see anything more around the mirror, but you do notice that you "+
					"can't see anything through the grime and dirt on the mirror.\n\n"+
					"Press R to Return roaming in your cell with the key";
					
			if 		(Input.GetKeyDown(KeyCode.R)) 		{myState = State.cell_1;}
	}
	
	void sheets_1(){
		text.text = "You don't find anything in the sheets, but you notice they don't smell " +
					"any better then before!\n\n" +
					"Press R to Return to roaming your cell with the key.";
		
			if 		(Input.GetKeyDown(KeyCode.R)) 		{myState = State.cell;}
	}
	
	void lock_1(){
		text.text = "You go to the lock and put the key in, but this shouldn't work, right? " +
					"You turn the key and viola, the lock turns and the cell door creaks " +
					"open just a tad.\n\n" +
					"Press E to escape out of the cell door or Press R to close the "+
					"door and return to roaming in your cell.";
			if 		(Input.GetKeyDown(KeyCode.E))		{myState = State.corridor_0;}
			else if (Input.GetKeyDown(KeyCode.R))		{myState = State.cell_1;}
		
	}
	
	void corridor_0(){
		text.text = "You step our of your cell and you are now in a corridor with noone around. "+
					"You look around.\n\n" +
					"Press S for Stairs, F for Floor, or C for Closet Door";
			if 		(Input.GetKeyDown(KeyCode.S))		{myState = State.stairs_0;}
			else if (Input.GetKeyDown(KeyCode.F))		{myState = State.floor;}
			else if (Input.GetKeyDown(KeyCode.C))		{myState = State.closet_door;}		
	
	}
	
	void stairs_0(){
		text.text = "You cautiously walk up the stairs to see if you can find a way out, but "+
					"you see a guard walking into a door and decide to go back to the corridor.\n\n"+
					"Press R to return to the corridor.";
			if 		(Input.GetKeyDown(KeyCode.R))		{myState = State.corridor_0;}
	}
	
	void closet_door(){
		text.text = "You go to the closet door, but it is locked! You will need to find something "+
					"to open it with.\n\n"+
					"Press R to return and keep looking for something.";
			if 		(Input.GetKeyDown(KeyCode.R))		{myState = State.corridor_0;}
			
	}
	
	void floor(){
		text.text = "You look on the floor and see something among the dirt. What is it that you see? "+
					"You look down and see that it is a hairpin. Can this help you?\n\n"+
					"Press P to pick up the hairpin, or press R to keep looking";
			if 		(Input.GetKeyDown(KeyCode.P))		{myState = State.corridor_1;}
			else if (Input.GetKeyDown(KeyCode.R))		{myState = State.corridor_0;}
							
	}
	
	void corridor_1(){
		text.text = "You stand in the corridor with the hairpin in your hand. You have to find out "+
					"where you can use this to get out and help find who killed the man in black!\n\n"+
					"Press S to go up Stairs, or press C to try the closet door";
			if 		(Input.GetKeyDown(KeyCode.S))		{myState = State.stairs_1;}
			else if (Input.GetKeyDown(KeyCode.C))		{myState = State.in_closet_0;}
			
	}	
	
	void stairs_1(){
		text.text = "You go up the stairs and look into the small window and see guards standing there "+
					"in the courtyard. You probably shouldn't go out there.\n\n"+
					"Press R to return to the corridor.";
			if 		(Input.GetKeyDown(KeyCode.R))		{myState = State.corridor_1;}
	}
	
	void in_closet_0(){
		text.text = "You put the hairpin in the lock and start picking it, but you don't know how "+
					"you know how to pick a lock, but you are doing it. The door opens up and you see "+
					"a janitor's uniform in there.\n\n"+
					"Press D to dress in the uniform, or press R to return to the corridor.";
			if 		(Input.GetKeyDown(KeyCode.D))		{myState = State.corridor_3;}
			else if (Input.GetKeyDown(KeyCode.R))		{myState = State.corridor_2;}
	}
	
	void corridor_2(){
		text.text = "You exit the closet not knowing if you should put the uniform on or not. "+
					"Something just doesn't seem right.\n\n"+
					"Press C to go back into the closet, or press S to go up the Stairs.";
			if 		(Input.GetKeyDown(KeyCode.C))		{myState = State.in_closet_1;}
			else if (Input.GetKeyDown(KeyCode.S))		{myState = State.stairs_1;}
								
	}
	
	void corridor_3(){
		text.text = "You get out of the closet with the janitor uniform on.\n\n"+
					"Press S to go up the stairs, or press U to get undressed and put your prisoner's "+
					"outfit back on.";
			if 		(Input.GetKeyDown(KeyCode.S))		{myState = State.courtyard;}
			else if (Input.GetKeyDown(KeyCode.U))		{myState = State.corridor_2;}
	}
	
	void in_closet_1(){
		text.text = "You go back into the closet and see the uniform hanging there.\n\n"+
					"Press D to dress in the uniform, or press R to return to the corridor.";
			if 		(Input.GetKeyDown(KeyCode.D))		{myState = State.corridor_3;}
			else if (Input.GetKeyDown(KeyCode.R))		{myState = State.corridor_2;}
			
	}
	
	void courtyard(){
		text.text = "You walk up the stairs and slowly push the door open and a guard looks at you "+
					"and nods his head, and you do the same. As you walk to the main gates you look "+
					"down and notice that you aren't wearing the janitor's uniform anymore, you are "+
					"wearing a suit, a black suit, and this isn't prision.\n\n"+
					"You have died as the man in black.\n\n"+
					"Press P to play again";
			if 		(Input.GetKeyDown(KeyCode.P))		{myState = State.cell;}
	}
	
					
}