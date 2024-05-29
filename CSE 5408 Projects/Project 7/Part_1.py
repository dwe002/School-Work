import cv2

#Assign png image to variable
img = cv2.imread('ChubbyCat.png')
 
#Draw circle around cat's head.
cv2.circle(img, (440,160), 100, (255, 0, 0), 5)

#print text on image 
img = cv2.putText(img,'Face detected!',(170,45),cv2.FONT_HERSHEY_SIMPLEX, 1.7, (255, 0, 0), 4)
 
#Display image
cv2.imshow("Part 1", img);
cv2.waitKey(0)
cv2.destroyAllWindows()

