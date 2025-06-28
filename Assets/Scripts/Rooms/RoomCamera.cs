using UnityEngine;

public class RoomCamera : MonoBehaviour
{
    [SerializeField] private Transform previousRoom;
    [SerializeField] private Transform nextRoom;
    [SerializeField] private CameraController cam;

    public static object main { get; internal set; }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.CompareTag("Player"))
        {
            bool goingLeft = collision.transform.position.x < transform.position.x;

            Transform targetRoom = goingLeft ? nextRoom : previousRoom;
            Transform oldRoom = goingLeft ? previousRoom : nextRoom;

            // Kamera geçiþi yap
            if (cam != null && targetRoom != null)
                cam.MoveToNewRoom(targetRoom);

            // Oda aktifliklerini ayarla
            if (targetRoom != null)
                targetRoom.GetComponent<Room>()?.ActivateRoom(true);

            if (oldRoom != null)
                oldRoom.GetComponent<Room>()?.ActivateRoom(false);
        }
    }

}
//if (collision.tag == "Player")
//{
//    if (collision.transform.position.x < transform.position.x)
//    {
//        cam.MoveToNewRoom(nextRoom);
//        nextRoom.GetComponent<Room>().ActivateRoom(true);
//        previousRoom.GetComponent<Room>().ActivateRoom(false);

//    }

//    else
//    {
//        cam.MoveToNewRoom(previousRoom);
//        previousRoom.GetComponent<Room>().ActivateRoom(true);
//        nextRoom.GetComponent<Room>().ActivateRoom(false);
//    }
//}