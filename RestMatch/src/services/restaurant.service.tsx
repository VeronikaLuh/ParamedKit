import ApiService from "@/services/api.service";
import {HttpMethods} from "@/types/enum";
import {Restaurant} from "@/models/Restaurant";

const getRestaurants = async () => {
  return await ApiService.makeApiRequest({
    url: '/api/restaurant',
    method: HttpMethods.GET
  });
}

const getRestaurant = async (id: number) => {
  return await ApiService.makeApiRequest({
    url: `/api/restaurant/${id}`,
    method: HttpMethods.GET
  });
}

const getCuisines = async () => {
  return await ApiService.makeApiRequest({
    url: '/api/cuisines',
    method: HttpMethods.GET
  });
}

const addRestaurant = async (restaurant: Restaurant) => {
  return await ApiService.makeApiRequest({
    url: '/api/restaurant',
    method: HttpMethods.POST,
    body: restaurant
  });
}

const updateRestaurant = async (restaurant: Restaurant, id: number) => {
  return await ApiService.makeApiRequest({
    url: `/api/restaurant/${id}`,
    method: HttpMethods.PUT,
    body: restaurant
  });
}

const deleteRestaurant = async (id: number) => {
  return await ApiService.makeApiRequest({
    url: `/api/restaurant/${id}`,
    method: HttpMethods.DELETE
  });
}

const restaurantService = {
  getRestaurants,
  getRestaurant,
  getCuisines,
  addRestaurant,
  updateRestaurant,
  deleteRestaurant,
}

export default restaurantService;