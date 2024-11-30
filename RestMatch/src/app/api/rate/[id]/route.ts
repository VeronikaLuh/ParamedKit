import ApiService from "@/services/api.service";
import {HttpMethods} from "@/types/enum";
import {NextResponse} from "next/server";

export async function GET(req: Request, {params}: { params: { id: string } }) {
  const id = parseInt(params.id, 10);

  const response = await ApiService.makeHttpsRequest({
    url: `${process.env.NEXT_PUBLIC_BACKEND_URL}/Rate/${id}`,
    method: HttpMethods.GET,
    req: req
  });

  return NextResponse.json({data: response});
}