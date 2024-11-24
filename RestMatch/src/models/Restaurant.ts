import {CuisineDto} from "@/models/Cuisines";
import {ImageUrl} from "@/models/ImageUrl";

export interface Restaurant {
  id: number;
  cuisines: CuisineDto[];
  imageUrls: ImageUrl[];
  name: string;
  country: string;
  city: string;
  address: string;
  rating: number;
  lowerPrice: number;
  upperPrice: number;
  openingTime: string;
  closingTime: string;
  phoneNumber: string;
  aboutText: string;
  menuUrl: string;
}