import { NextResponse } from "next/server";
import ApiService from "@/services/api.service";
import {HttpMethods} from "@/types/enum";

// export async function GET(req: Request, {params} : { params: Promise<{ id: string }> }) {
export async function GET(req: Request) {
  const { searchParams } = new URL(req.url);
  const pageNumber = searchParams.get('pageNumber');
  const pageSize = searchParams.get('pageSize');

  try {
    const response = await ApiService.makeHttpsRequest({
      url: `${process.env.NEXT_PUBLIC_BACKEND_URL}/Restaurants/hello?pageNumber=${pageNumber}&pageSize=${pageSize}`,
      method: HttpMethods.GET,
      req: req
    });

    return NextResponse.json({data: response});
  }

  catch (error: any) {
    console.error('Error in GET handler:', error.message);

    // Return a 500 status with the error message
    return NextResponse.json(
      { error: 'Failed to fetch recommendations', details: error.message },
      { status: 500 }
    );
  }
}
