export interface Rate {
  "id": number,
  "restaurantId": number,
  "user": {
    "id": number,
    "nickName": string,
    "imageUrl": string
  },
  "title": string,
  "text": string,
  "rating": number
}