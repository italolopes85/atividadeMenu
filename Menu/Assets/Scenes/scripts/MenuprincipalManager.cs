using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuprincipalManager : MonoBehaviour
{
    [SerializeField] private string nomeDoLevelDEJogo;
    [SerializeField] private  GameObject painelMenuInicial;
    [SerializeField] private  GameObject painelOpções;
    public void Jogar()
    {
        SceneManager.LoadScene(nomeDoLevelDEJogo);
    }

    public void AbrirOpcoes()
    {
        painelMenuInicial.SetActive(false);
        painelOpções.SetActive(true);
    }
    public void FecharOpcoes()
    {
        painelOpções.SetActive(true); 
        painelMenuInicial.SetActive(false);
    }

    public void SairJogo()
    {
        Debug.Log("Sair do Jogo");
        Application.Quit();
    }
}
