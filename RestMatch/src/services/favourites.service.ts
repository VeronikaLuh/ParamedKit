import ApiService from "@/services/api.service";
import {HttpMethods} from "@/types/enum";

const getFavourites = async () => {
  return await ApiService.makeAuthApiRequest({
    url: `/api/favourites`,
    method: HttpMethods.GET,
  });
}

const addFavourites = async (id: string) => {
  return await ApiService.makeAuthApiRequest({
    url: `/api/favourites/${id}`,
    method: HttpMethods.POST
  });
}

const deleteFavourites = async (id: string) => {

}

export const favouritesService = {
  getFavourites,
  addFavourites,
  deleteFavourites
}