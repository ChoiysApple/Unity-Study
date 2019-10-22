# Rotation & Quaternion

// Rotation is not Vector3
    transform.rotation = new Vector3(30, 30, 30);
    
    // Euler function transform Vector3 into Quaternion
    transform.rotation = Quaternion.Euler(new Vector3(30, 30, 30));

### Gimbal lock

Axis disappear when two axis (before & after rotation) overlapped 
This is why Unity use **Quaternion** with Vector

### Making the object to look other object

    Vector3 direction = targerTransform.position - transform.position
    
    // LookRotation - set which direction the object will look(Z direction)
    Quaternion targerRotation = Quaternion.LookRotation(direction)

### Finding Median point

    Quaternion aRotation = Quaternion.Euler(new Vector(30, 0, 0))
    Quaternion bRotation = Quaternion.Euler(new Vector(90, 0, 0))
    
    // Find 50% Median between aRotation & bRotation
    Quaternion targetRotation= Quaternion.Lerp(aRotation, bRotation, 0.5f)

### Rotate More

    // Rotate 30 degrees more on the x-axis
    transform.Rotate(new Vector3(30, 0, 0))

    // eulerAngle - Quaternion into Vector3
    Quaternion originalRotation = transform.rotation
    
    Vector3 originalROtationInVector3 = originalROtation.eulerAngles;
    Vector3 targerRotationVector = originalRotationInVector3 + new Vector3(30, 0, 0);
    
    transform.rotation = Quaternion.Euler(targetRotationVector);

    // Multiply of several Quaternion - Sum of angle
    Quaternion originalRotation = Quaternion.Euler(new Vector3(45, 0, 0));
    Quaternion plusRotation = Quaternion.Euler(new Vector3(30, 0, 0));
    
    transform.rotation = originalRotation * plusRotation