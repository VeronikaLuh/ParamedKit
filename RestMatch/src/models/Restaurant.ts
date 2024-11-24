import {Cuisine} from "@/models/Cuisinej";
import {ImageUrl} from "@/models/ImageUrl";

export interface Restaurant {
  id: number;
  cuisines: Cuisine[];
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