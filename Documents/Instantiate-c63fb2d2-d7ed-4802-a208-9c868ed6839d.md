# Instantiate

Spawn original GameObject in Game, Real time (Spawner - Monster, Bullet)

### Spawn at GameObject Spawner

    public GameObject target;       //Something to spawn
    
    void Start(){
    Instantiate(target);            // spawn object
    }
    

### Spawn at custom position

    public Tramsform spawnPosition; // Spawn position (new object)
    public GameObject target;       // Something to spawn
    
    void Start(){
    // spawn object with other position, rotation
    Instantiate(target, spawnPosition.position, spawnPosition.rotation);            
    }
    

### Get spawned object or original object

    public Tramsform spawnPosition; // Spawn position (new object)
    public GameObject target;       // Something to spawn
    
    void Start(){
    // instantiated - spawned object
    GameObject instantiated 
    = Instantiate(target, spawnPosition.position, spawnPosition.rotation);            
    }
    

    public Tramsform spawnPosition; // Spawn position (new object)
    public Rigidbody target;       // Something to spawn
    
    void Start(){
    // instantiated - spawned object's Rigidbody
    Rigidbody instantiated 
    = Instantiate(target, spawnPosition.position, spawnPosition.rotation);            
    }