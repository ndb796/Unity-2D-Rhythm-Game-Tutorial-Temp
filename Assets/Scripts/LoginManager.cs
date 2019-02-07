using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoginManager : MonoBehaviour {

    // 파이어베이스 인증 기능 객체
    private Firebase.Auth.FirebaseAuth auth;

    // 이메일 및 패스워드 UI
    public InputField emailInputField;
    public InputField passowordInputField;

    // 회원가입 결과 UI
    public Text messageUI;

    void Start()
    {
        // 파이어베이스 인증 객체를 초기화합니다.
        auth = Firebase.Auth.FirebaseAuth.DefaultInstance;
        messageUI.text = "";
    }

    public void Login()
    {
        string email = emailInputField.text;
        string password = passowordInputField.text;
        // 인증 객체를 이용해 이메일과 비밀번호로 로그인을 수행합니다.
        auth.SignInWithEmailAndPasswordAsync(email, password).ContinueWith(
            task => {
                if (task.IsCompleted && !task.IsCanceled && !task.IsFaulted)
                {
                    PlayerInformation.auth = auth;
                    SceneManager.LoadScene("GameSelectScene");
                }
                else
                {
                    messageUI.text = "계정을 다시 확인해주세요.";
                }
            }
        );
    }

    public void Join()
    {
        SceneManager.LoadScene("JoinScene");
    }

}
