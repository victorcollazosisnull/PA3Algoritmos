using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField] private Button Jugar;
    [SerializeField] private Button salir;
    private void Awake()
    {
        Jugar.onClick.AddListener(OnclikJugar);
        salir.onClick.AddListener(OnclikSalir);
    }
    private void OnclikSalir()
    {

        print("Saliste");
        Application.Quit();
    }
    private void OnclikJugar()
    {
        SceneManager.LoadScene("Game");
    }
}
