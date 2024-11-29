import ApiService from "@/services/api.service";
import {HttpMethods} from "@/types/enum";
import {Restaurant} from "@/models/Restaurant";

const getRecommendations = async (pageNumber: number, pageSize: number) => {
  return await ApiService.makeAuthApiRequest({
    url: `/api/restaurant/recommendations?pageNumber=${pageNumber}&pageSize=${pageSize}`,
    method: HttpMethods.GET
  });
}

interface RestaurantQueryParams {
  location?: string;
  lowestPrice?: string;
  highestPrice?: string;
  sortOrder?: string;
  pageNumber?: string;
}

const getRestaurants = async (params: RestaurantQueryParams = {}) => {
  const queryParams = new URLSearchParams();

  Object.entries(params).forEach(([key, value]) => {
    if (value !== undefined && value !== null) {
      queryParams.append(key, value);
    }
  });

  const url = `/api/restaurant${queryParams.toString() ? `?${queryParams.toString()}` : ''}`;

  return await ApiService.makeApiRequest({
    url,
    method: HttpMethods.GET
  });
}

const getRestaurant = async (id: string) => {
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
  getRecommendations
}

export default restaurantService;