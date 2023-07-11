xpublic void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.tag == "door")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }

    }
