using UnityEngine;
using Photon.Pun;

public class isMine : MonoBehaviour
{
    [SerializeField] private PlayerMovement1 _playerMovement1;
    [SerializeField] private MouseLook1 _mouseLook1;
    [SerializeField] private GameObject _camera;
    [SerializeField] private PhotonView _photonView;
    [SerializeField] private GameObject _playerModel;

    void Start()
    {
        if (!_photonView.IsMine)
        {
            _playerMovement1.enabled = false;
            _mouseLook1.enabled = false;
            _camera.SetActive(false);
            _playerModel.SetActive(true);
        }
    }

}
