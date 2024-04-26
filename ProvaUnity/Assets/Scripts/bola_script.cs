using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using Random = UnityEngine.Random;

public class Bola_script : MonoBehaviour
{
    public float velocidade = 10;
    private float x; 
    private float y = -1; // Defini que a bolinha sempre vai começar para baixo
    // Aqui criei a velocidade, o X e o Y que vão definir o X e Y do meu Vector2 que vai ser a velocidade da bola


    [SerializeField] private GameObject[] Blocos = new GameObject[10];
    // Aqui criei um SerializeField para alocar meu gameobject(Blocos) nesse gameobject
    // Criei ele como uma array para colocar cada bloco como um elemento

    public TMP_Text Score;
    // Aqui criei meu texto para marcar a quantidade de blocos que o jogador vai destruir
    // Ele está (TMP_Text), pq é um texto que tem um componente TextMeshPro
    int score;
    // Nessa variavel eu vou salvar a contagem


    [SerializeField] private GameObject TextoWin;
    [SerializeField] private GameObject TextoLose;
    // Aqui criei os textos para vitoria e derrota
    // Assim como os Blocos, eu vou fazer deixa ele desativados na unity e ativos no código
    

    void Start()
    {
        if (Random.Range(0, 2) != 0)
        {
            x = 1; 
        }
        else
        {
            x = -1;
        }
        // Aqui quando o game começa a bolinha vai para o lado do 3°quadrante ou 4°quadrante no plano

        GetComponent<Rigidbody>().velocity = new Vector2((velocidade * x), (velocidade * y));
        // Adicionei um dos atributos que tem no RigidBody que é a velocity
        // E usei Vector2, pq ele vai fazer os vetor ser 2D tendo só X e Y, sem o Z
        // assim a bolinha não vai para traz
        Debug.Log(GetComponent<Rigidbody>().velocity);

        Score.SetText(score.ToString());
        score = 0;
        Blocos[0].SetActive(true);
        Blocos[1].SetActive(true);
        Blocos[2].SetActive(true);
        Blocos[3].SetActive(true);
        Blocos[4].SetActive(true);
        Blocos[5].SetActive(true);
        Blocos[6].SetActive(true);
        Blocos[7].SetActive(true);
        Blocos[8].SetActive(true);
        Blocos[9].SetActive(true);
        Blocos[10].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void OnCollisionEnter(Collision batida)
    {
        if (batida.gameObject.name == "Floor")
        {
            transform.position = new Vector3((float)-0.19, (float)3.36, 0);
            GetComponent<Rigidbody>().velocity = new Vector2(0, 0);
            Derrota();
        }

        if (batida.gameObject.name == "Bloco")
        {
            Blocos[0].SetActive(false);
            score++;
            Score.SetText(score.ToString());
            Vitoria();
            // Quando a bolinha bater o bloco vai ser desativado, assim sumindo da tela
            // Vou somar +1 no score
            // Vou mudar o Texto
            // E vou checar se o jogador Ganhou (se score = 12)

            // Todos os outros são a mesma coisa
        }
        else if (batida.gameObject.name == "Bloco2")
        {
            Blocos[1].SetActive(false);
            score++;
            Score.SetText(score.ToString());
            Vitoria();
        }
        else if (batida.gameObject.name == "Bloco3")
        {
            Blocos[2].SetActive(false);
            score++;
            Score.SetText(score.ToString());
            Vitoria();
        }
        else if (batida.gameObject.name == "Bloco4")
        {
            Blocos[3].SetActive(false);
            score++;
            Score.SetText(score.ToString());
            Vitoria();
        }
        else if (batida.gameObject.name == "Bloco5")
        {
            Blocos[4].SetActive(false);
            score++;
            Score.SetText(score.ToString());
            Vitoria();
        }
        else if (batida.gameObject.name == "Bloco6")
        {
            Blocos[5].SetActive(false);
            score++;
            Score.SetText(score.ToString());
            Vitoria();
        }
        else if (batida.gameObject.name == "Bloco7")
        {
            Blocos[6].SetActive(false);
            score++;
            Score.SetText(score.ToString());
            Vitoria();
        }
        else if (batida.gameObject.name == "Bloco8")
        {
            Blocos[7].SetActive(false);
            score++;
            Score.SetText(score.ToString());
            Vitoria();
        }
        else if (batida.gameObject.name == "Bloco9")
        {
            Blocos[8].SetActive(false);
            score++;
            Score.SetText(score.ToString());
            Vitoria();
        }
        else if (batida.gameObject.name == "Bloco10")
        {
            Blocos[9].SetActive(false);
            score++;
            Score.SetText(score.ToString());
            Vitoria();
        }
        else if (batida.gameObject.name == "Bloco11")
        {
            Blocos[10].SetActive(false);
            score++;
            Score.SetText(score.ToString());
            Vitoria();
        }
    }
    
    void Vitoria()
    {
        if (score == 11)
        {
            TextoWin.SetActive(true);    
            // Vou fazer o texto aparecer na tela
        }
    }

    void Derrota()
    {
        TextoLose.SetActive(true);
        // Memsa coisa do de cima
    }
    
}
