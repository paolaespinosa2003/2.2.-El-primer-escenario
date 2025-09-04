using UnityEngine;

public class AbrirEnlace : MonoBehaviour
{
    public void AbrirGoogle()
    {
        Application.OpenURL("https://www.google.com");
    }

    public void AbrirYouTube()
    {
        Application.OpenURL("https://www.youtube.com");
    }

    public void AbrirWikipedia()
    {
        Application.OpenURL("https://www.wikipedia.org");
    }
}
