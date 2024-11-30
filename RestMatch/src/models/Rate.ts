export interface Rate {
  "id"?: string,
  "restaurantId": string,
  "user"?: {
    "id": number,
    "nickName": string,
    "imageUrl": string
  },
  "title": string,
  "text": string,
  "rating": number
}