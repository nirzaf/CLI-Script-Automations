// In this challenge, the task is to implement a class called NotesStore.
// The class will manage a collection of notes, with each note having a
// state and a name. Valid states for notes are 'completed', 'active', and
// 'others'. All other states are invalid.


// Your implementation of the function will be tested by a stubbed code
// on several input files. Each input file contains parameters for the
// function calls. The functions will be called with those parameters, and
// the result of their executions will be printed to the standard output by
// the stubbed code. The stubbed code joins the strings returned by the
// GetNotes function with a comma and prints to the standard output. If
// GetNotes returns an empty list, the stubbed code prints 'No Notes'.
// The stubbed code also prints messages of all the thrown errors.

public class NotesStore
{
    public NotesStore(){}
    public void AddNote(string state, string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new Exception("Name cannot be empty");
        }
        else if (state != "completed" || state != "active" || state != "others")
        {
            throw new Exception("Invalid state (" + state + ")");
        }
    }

    // 2. GetNotes(state); returns a list of note names with the given state
    // (string) added so far. The names are returned in the order the
    // corresponding notes were added. In addition to that:
    // • If the given state is not a valid note state, then it throws an
    // Exception with the message 'Invalid state (state)'.
    // • If no note is found in this state, it returns an empty list.
    // Note: The state names are case-sensitive.

}