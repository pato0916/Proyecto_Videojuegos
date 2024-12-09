using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class WinTrigger : MonoBehaviour
{
    public GameObject youWinText;
    private float delay = 3f; // Valor fijo de delay en 3 segundos

    void Start()
    {
        youWinText.SetActive(false); // Asegura que el texto esté oculto al iniciar
    }

    private void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto que tocó el cubo tiene el tag "Player"
        if (other.CompareTag("Player"))
        {
            // Muestra el texto de victoria
            youWinText.SetActive(true);
            StartCoroutine(Countdown());
        }
    }

    IEnumerator Countdown()
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(0); // Reinicia la escena después del retraso
    }
}
