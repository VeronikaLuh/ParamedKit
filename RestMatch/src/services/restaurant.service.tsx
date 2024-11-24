import ApiService from "@/services/api.service";
import {HttpMethods} from "@/types/enum";

const getRestaurants = async () => {
  return await ApiService.makeApiRequest({
    url: '/api/restaurant',
    method: HttpMethods.GET
  });
}

// const createOrder = async (order: Order) => {
//   return await ApiService.makeApiRequest({
//     url: '/api/order',
//     method: HttpMethods.POST,
//     body: order
//   });
// }

const restaurantService = {
  getRestaurants
}

export default restaurantService;