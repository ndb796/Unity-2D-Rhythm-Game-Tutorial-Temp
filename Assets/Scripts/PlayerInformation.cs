using Firebase;
using Firebase.Database;
using Firebase.Unity.Editor;

public static class PlayerInformation {

    public static string selectedMusic;
    public static int maxCombo;
    public static float score;
    public static string musicTitle;
    public static string musicArtist;
    public static Firebase.Auth.FirebaseAuth auth;

    public static DatabaseReference GetDatabaseReference()
    {
        FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("https://unity-rhythm-game-tutorial.firebaseio.com/");
        return Firebase.Database.FirebaseDatabase.DefaultInstance.RootReference;
    }

}