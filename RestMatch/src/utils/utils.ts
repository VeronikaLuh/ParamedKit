import {Cuisine} from "@/models/Cuisines";

export const findRightCuisineType = (cuisines: Cuisine[], cuisineId: number) => {
  const cuisine = cuisines.find(cuisine => cuisine.id === cuisineId);
  if (!cuisine) {
    return 'Unknown';
  }
  return cuisine.name;
}