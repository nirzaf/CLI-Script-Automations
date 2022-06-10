// In this challenge, the task is to implement a class called NotesStore.
// The class will manage a collection of notes, with each note having a
// state and a name. Valid states for notes are 'completed', 'active', and
// 'others'. All other states are invalid.
public class NotesStore
{
    private Dictionary<string, string> notes;
    public NotesStore(){}
        // 1. AddNote(state, name) adds a note with the given name (string) and
        // state (string) to the collection. In addition to that:
        // • If the passed name is empty, then it throws an Exception with
        // the message 'Name cannot be empty'.
        // • If the passed name is non-empty but the given state is not a
        // valid state for a note, then it throws an Exception with the
        // message 'Invalid state (state)'.
    public void AddNote(string state, string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new Exception("Name cannot be empty");
        }
        else if (state != "completed" || state != "active" || state != "others")
        {
            throw new Exception($"Invalid state {state}");
        }
        else
        {
            notes.Add(name, state);
        }
    }

        // 2. GetNotes(state); returns a list of note names with the given state
        // (string) added so far. The names are returned in the order the
        // corresponding notes were added. In addition to that:
        // • If the given state is not a valid note state, then it throws an
        // Exception with the message 'Invalid state (state)'.
        // • If no note is found in this state, it returns an empty list.
        // Note: The state names are case-sensitive.
        public List<string> GetNotes(string state)
        {
            if (state != "completed" || state != "active" || state != "others")
            {
                throw new Exception($"Invalid state { state } ");
            }

            var filteredNotes = notes.Where(x => x. == state).Select(x => x.Key);
            else
            {
                return new List<string>();
            }
        }

}