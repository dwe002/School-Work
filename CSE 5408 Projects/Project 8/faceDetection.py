import cv2

#assigns video to variable "capture"
capture = cv2.VideoCapture('face-demographics-walking.mp4')


#reads video
while True:
    isTrue, frame = capture.read()
    
    #creates the haar cascade
    faceCascade = cv2.CascadeClassifier('haar_face-1.xml')

    #makes frames gray scale
    gray = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)

    #detects faces in each frame
    faces = faceCascade.detectMultiScale(
        gray,
        scaleFactor = 1.1,
        minNeighbors = 3,
        minSize=(30, 30),
    )

    #draws green rectangle around the faces
    for (x, y, w, h) in faces:
        cv2.rectangle(frame, (x, y), (x+w, y+h), (0, 255, 0), 2)
    
    #shows video    
    cv2.imshow('face-demographics-walking.mp4', frame)
    
    
    #ends video
    if cv2.waitKey(20) & 0xFF==ord('d'):
        break

#ends program
capture.release()
cv2.waitKey(0)
cv2.destroyAllWindows()