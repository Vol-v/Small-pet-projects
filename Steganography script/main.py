import random
import numpy as np
from PIL import Image


def steganography(picture_path, message_path):
    image = Image.open(picture_path)  # Open image
    width = image.size[0]
    height = image.size[1]
    keys = []
    message = open(message_path).read()
    img_array = np.array(Image.open(picture_path))  # Transform image to NumPy array
    img_array.setflags(write=1)
    std = 0
    std_ind = 0

    for count, n in enumerate(img_array): # Get row with biggest standard deviation on red color
        if np.std(n[:,0]) > std:
            std = np.std(n[:, 0])
            std_ind = count

    save_row = img_array[std_ind]  # Save this row and remove it from image
    print(img_array[std_ind].flags)
    img_array = np.delete(img_array, std_ind, 0)

    for a in message:
        key = (round(random.randint(1, img_array.shape[0]) * (255 / max(height,width))),
               round(random.randint(1, img_array.shape[1]) * (255 / max(height,width))))  # Create and save keys
        keys.append(key)
        img_array[key[0], key[1], 2] = ord(a)  # Encrypt the message

    save_row[0,2] = len(keys)

    for count in range(1,len(keys) + 1):
        save_row[count, 1] = keys[count - 1][0]
        save_row[count, 2] = keys[count - 1][1]

    img_array = np.insert(img_array,std_ind,save_row,0) #insert row with keys back in the image
    image2 = Image.fromarray(img_array)
    image2.save("ans.png","PNG")
    print("Image was successfully saved!")
    return

def decrypt(path):
    img_array = np.array(Image.open(path)) # Open image
    std = 0
    std_ind = 0

    for count, n in enumerate(img_array): # Get row with biggest standard deviation on red color
        if np.std(n[:, 0]) > std:
            std = np.std(n[:, 0])
            std_ind = count

    amount = img_array[std_ind,0,2]

    message = []
    for i in range(1,amount + 1):
        key = (img_array[std_ind,i,1], img_array[std_ind,i,2])
        message.append(chr(img_array[key[0],key[1],2]))
    print("Message: "," ".join(message))


# Press the green button in the gutter to run the script.
if __name__ == '__main__':
    steganography("pic.jpg", "message.txt")

    decrypt("ans.png")

