import cv2

#Assign png image to variable
img = cv2.imread('ChubbyCat.png')
 
#Assign gray scale image
gray_img = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)

#Asssign edged gray scale image
edges = cv2.Canny(gray_img, 100,200)
 
#Display images
cv2.imshow("Edge Image", edges);
cv2.imshow("Gray Scale Image", gray_img);
cv2.waitKey(0)
cv2.destroyAllWindows()
